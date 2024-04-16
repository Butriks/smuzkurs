using System;
using System.Windows;
using System.Windows.Controls;

namespace smkurs
{
    public partial class MainWindow : Window
    {
        // Поля для хранения логина и пароля
        private string login;
        private string password;

        public MainWindow()
        {
            InitializeComponent();
        }

        

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            // Получаем текст из поля ввода логина и пароля
            TextBox loginTextBox = FindName("loginTextBox") as TextBox;
            PasswordBox passwordBox = FindName("passwordBox") as PasswordBox;

            if (loginTextBox != null && passwordBox != null)
            {
                login = loginTextBox.Text;
                password = passwordBox.Password;




                if (!string.IsNullOrWhiteSpace(login) && !string.IsNullOrWhiteSpace(password))
                {
                    // Проверяем, существует ли пользователь с таким логином и паролем
                    

                }
                    else if (true)
                    {
                        
                    }
                    else
                    {
                        

                        //TaskList tasklist = new TaskList(existingUser.id);
                    }
                }
                else
                {
                    MessageBox.Show("Пожалуйста, заполните оба поля (логин и пароль).");
                }
            }
        }
    }

