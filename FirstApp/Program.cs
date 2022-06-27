/*
 * Производный класс обязан реализовать все абстрактные члены базового класса. 
 * Однако мы можем отказаться от реализации, но в этом случае производный класс 
 * также должен быть определен как абстрактный
 * 
 * Таким образом, в классе DerivedAbstractClass мы можем не определять реализацию 
 * поля Name, но в производных от этого класса классах всё равно будем обязаны это сделать.
 */

abstract class AbstractClass
{
    public abstract string Name
    {
        get;
        set;
    }
}

abstract class DerivedAbstractClass : AbstractClass
{
    public abstract void Display();
}