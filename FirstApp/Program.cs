﻿/*
 * При этом класс SystemUnit полностью управляет жизненным циклом объекта MotherBoard. 
 * При уничтожении объекта SystemUnit в области памяти вместе с ним будет уничтожен и 
 * объект MotherBoard. И в этом плане объект системного блока является главным, когда 
 * объект материнской платы — зависимым.
 * 
 * На диаграммах UML отношение композиции изображается обычной стрелкой от главной сущности 
 * к зависимой, при этом со стороны главной сущности, которая содержит объект второй сущности, 
 * располагается закрашенный ромбик
 */

class MotherBoard
{
}
class SystemUnit
{
    private MotherBoard motherBoard;

    public SystemUnit()
    {
        motherBoard = new MotherBoard();
    }
}