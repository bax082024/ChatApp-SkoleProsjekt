using ChatApp_SkoleProsjekt.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApp_SkoleProsjekt.UI
{
    public partial class ResetPasswordForm : Form
    {
        private readonly AuthenticationHelper _authService;
        private string _username;

        public ResetPasswordForm()
        {
            InitializeComponent();
        }
    }


}
