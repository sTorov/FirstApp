abstract class ComputerPart
{
    public abstract void Work();
}
class Processor : ComputerPart
{
    public override void Work() {}
}
class MotherBoart : ComputerPart
{
    public override void Work() {}
}
class GraphicCard : ComputerPart
{
    public override void Work() {}
}