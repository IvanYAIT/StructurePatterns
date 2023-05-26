//предназначен для преобразования интерфейса одного класса в интерфейс другого

class Target
{
    public virtual void Request() { }
}

class Adapter : Target
{
    private Adaptee adaptee = new Adaptee();

    public override void Request() =>
        adaptee.SpecificRequest();
}

class Adaptee
{
    public void SpecificRequest() { }
}