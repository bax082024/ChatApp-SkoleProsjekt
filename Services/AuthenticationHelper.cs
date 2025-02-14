﻿using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using ChatApp_SkoleProsjekt.Models;
using System.Text.RegularExpressions;
using System.Xml;

namespace ChatApp_SkoleProsjekt.Services
{
    public class AuthenticationHelper
    {
        private const string UserFilePath = "users.json";

        public List<User> LoadUsers()
        {
            if (!File.Exists(UserFilePath)) return new List<User>();
            string json = File.ReadAllText(UserFilePath);
            return JsonConvert.DeserializeObject<List<User>>(json) ?? new List<User>();

        }

        public void SaveUsers(List<User> user)
        {
            string json = JsonConvert.SerializeObject(user, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(UserFilePath, json);
        }

        public bool RegisterUser(string username, string password, string secretQuestion, string secretAnswer)
        {
            if (!IsValidUsername(username) || !IsValidPassword(password)) return false;

            var users = LoadUsers();
            if (users.Any(u => u.Username == username)) return false;

            string salt = GenerateSalt();
            string passwordHash = HashPassword(password, salt);
            string secretAnswerHash = HashPassword(secretAnswer, salt);

            var newUser = new User
            {
                Username = username,
                PasswordHash = passwordHash,
                Salt = salt,
                SecretQuestion = secretQuestion,
                SecretAnswerHash = secretAnswerHash
            };

            users.Add(newUser);
            SaveUsers(users);
            return true;
        }

        public bool AuthenticateUser(string username, string password)
        {
            var users = LoadUsers();
            var user = users.FirstOrDefault(u => u.Username == username);
            if (user == null) return false;

            string hashedInput = HashPassword(password, user.Salt);
            return hashedInput == user.PasswordHash;
        }

        public bool ValidateSecretAnswer(string username, string answer)
        {
            var users = LoadUsers();
            var user = users.FirstOrDefault(u => u.Username == username);
            if (user == null) return false;

            string hashedAnswer = HashPassword(answer, user.Salt);
            return hashedAnswer == user.SecretAnswerHash;
        }

        public string HashPassword(string input, string salt)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(input + salt);
                byte[] hash = sha256.ComputeHash(bytes);
                return Convert.ToBase64String(hash);
            }
        }

        public string GenerateSalt()
        {
            byte[] saltBytes = new byte[16];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(saltBytes);
            }
            return Convert.ToBase64String(saltBytes);
        }

        public bool IsValidUsername(string username)
        {
            return !string.IsNullOrWhiteSpace(username) && username.Length >= 4;
        }

        public bool IsValidPassword(string password)
        {
            return password.Length >= 8 &&
                Regex.IsMatch(password, @"\d") &&
                Regex.IsMatch(password, @"[!@#$%^&*(),.?""{}|<>]");
        }

        public User GetUserByUsername(string username)
        {
            var users = LoadUsers();
            return users.FirstOrDefault(u => u.Username == username);
        }
    }
}