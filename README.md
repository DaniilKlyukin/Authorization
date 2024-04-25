# Authorization
## Окно авторизации

![image](https://github.com/DaniilKlyukin/Authorization/assets/32903150/5d0b56ba-2d88-441d-87bb-34414708b2ed)

Пример проверки при входе
```cs
using System.Diagnostics;

var login = "Login";
var password = "Password";

if (AuthorizationController.TryLogin(login, password))
{
    Debug.WriteLine("Succes!");
}
else
{
    Debug.WriteLine("Fail!");
}
```

## Окно регистрации
 
![image](https://github.com/DaniilKlyukin/Authorization/assets/32903150/77338fef-c228-461f-8a5d-6af5c1a24908)

Пример регистрации
```cs
using System.Diagnostics;

var login = "Login";
var password = "Password";
var mail = "example@mail.ru";

if (!AuthorizationController.TryRegister(login, password, mail, out var message))
{
    Debug.WriteLine(message);
    return;
}

```
