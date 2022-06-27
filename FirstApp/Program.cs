/*
 * При агрегации реализуется слабая связь, то есть в данном случае объекты SystemUnit и 
 * MotherBoard будут равноправны. В конструктор SystemUnit передается ссылка на уже имеющийся 
 * объект MotherBoard, который был создан вне SystemUnit.
 * 
 * Отношение агрегации на диаграммах UML отображается также, как и отношение композиции, 
 * только теперь ромбик будет незакрашенным
 */

class MotherBoard
{
}
class SystemUnit
{
    private MotherBoard motherBoard;

    public SystemUnit(MotherBoard motherBoard)
    {
        this.motherBoard = motherBoard;
    }
}