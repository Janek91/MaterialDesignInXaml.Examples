﻿using System;
using System.Windows.Controls;

namespace DialogHost.ChangingContent.CodeBehind
{
    /// <summary>
    /// Interaction logic for LoginControl.xaml
    /// </summary>
    public partial class LoginControl : UserControl
    {
        private MaterialDesignThemes.Wpf.DialogHost DialogHost { get; }

        public LoginControl(MaterialDesignThemes.Wpf.DialogHost dialogHost, string username)
        {
            InitializeComponent();
            Username.Text = username;
            DialogHost = dialogHost ?? throw new ArgumentNullException(nameof(dialogHost));
        }

        private void CreateAccount_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (DialogHost.CurrentSession is DialogSession session)
            {
                session.UpdateContent(new CreateAccountControl(DialogHost, Username.Text));
            }
        }
    }
}
