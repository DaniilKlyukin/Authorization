using System.Text.RegularExpressions;
using System.Security.Cryptography;
using System.Text;

namespace Authorization
{
    public static class AuthorizationController
    {
        private const int
            MinLoginLength = 3,
            MinPasswordLength = 8;

        // Файл данных имеет вид:
        // Логин1 Пароль1
        // Логин2 Пароль2
        // ...
        private const string DataBase = "database.txt";

        private static string encrypt(string str)
        {
            var data = Encoding.UTF8.GetBytes(str);
            data = SHA256.HashData(data);
            return Encoding.UTF8.GetString(data);
        }

        private static bool checkLogin(string login, out string message)
        {
            if (string.IsNullOrWhiteSpace(login))
            {
                message = "Логин не должен быть пуст";
                return false;
            }

            if (Regex.IsMatch(login, @"\W"))
            {
                message = "Логин должен состоять только из символов слова";
                return false;
            }

            if (login.Length <= MinLoginLength)
            {
                message = $"Логин должен быть длиннее {MinLoginLength} символов";
                return false;
            }

            message = string.Empty;
            return true;
        }

        private static bool checkPassword(string password, out string message)
        {
            if (string.IsNullOrWhiteSpace(password))
            {
                message = "Пароль не должен быть пуст";
                return false;
            }

            if (Regex.IsMatch(password, @"\W"))
            {
                message = "Пароль должен состоять только из символов слова";
                return false;
            }

            if (password.Length <= MinPasswordLength)
            {
                message = $"Пароль должен быть длиннее {MinPasswordLength} символов";
                return false;
            }

            message = string.Empty;
            return true;
        }

        private static bool checkMail(string mail, out string message)
        {
            if (string.IsNullOrWhiteSpace(mail))
            {
                message = "Почта не должна быть пустой";
                return false;
            }

            // ***@***.***   Пример: login@mail.ru
            if (!Regex.IsMatch(mail, @"\S+@\S+\.\S+"))
            {
                message = "Почта не соответствует шаблону";
                return false;
            }

            message = string.Empty;
            return true;
        }

        private static bool isLoginExist(string login)
        {
            using var sr = new StreamReader(DataBase);
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    var lineLogin = line.Split(' ')[0];

                    if (lineLogin == login)
                        return true;
                }
            }

            return false;
        }

        public static bool TryLogin(string login, string password)
        {
            var passwordHash = encrypt(password);

            using var sr = new StreamReader(DataBase);
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    var temp = line.Split('\t');
                    var dbLogin = temp[0];
                    var dbPasswordHash = temp[1];

                    // При проверке пароля НЕ нужно его расшифровывать,
                    // необходимо наоборот - шифровать то, что ввел пользователь
                    // и сравнивать хеши (шифры)
                    if (dbLogin == login && dbPasswordHash == passwordHash)
                        return true;
                }
            }

            return false;
        }

        public static bool TryRegister(string login, string password, string mail, out string message)
        {
            if (!checkLogin(login, out message))
                return false;

            if (!checkPassword(password, out message))
                return false;

            if (!checkMail(mail, out message))
                return false;

            if (isLoginExist(login))
            {
                message = "Такой пользователь уже существует";
                return false;
            }

            // Храним пароль в зашифрованном виде
            File.AppendAllText(DataBase, $"{login}\t{encrypt(password)}\n");

            message = string.Empty;
            return true;
        }
    }
}