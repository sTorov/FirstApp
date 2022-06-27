﻿/*
 * Наследование является базовым принципом ООП и позволяет классу-наследнику унаследовать
 * функционал родительского класса. Отношения наследования еще называют генерализацией или
 * обобщением. Наследование определяет отношение IS A, то есть «является»
 */

class User
{
    public string Login;
    public string Name;
}

class Admin : User
{
    public void ManageUsers()
    {
        // ...
    }
}