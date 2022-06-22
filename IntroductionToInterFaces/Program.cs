using System;

public class Program
{
    static void Main()
    {
        Machine1 m1 = new Machine1();
        Machine2 m2 = new Machine2();
        Machine3 m3 = new Machine3();

        m1.Start();
        m1.Stop();

        m2.Start();
        m2.Stop();

        m3.Start();
        m3.Stop();

    }
}


public class Machine1:Icontrols
{
    public void Start()
    {

    }

    public void Stop()
    {
        throw new NotImplementedException();
    }
}
public class Machine2:Icontrols
{
    public void On()
    {

    }

    public void Start()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }
}
public class Machine3:Icontrols
{
    public void StartUp()
    {

    }
    public void Start()
    {
        throw new NotImplementedException();
    }
    public void Stop()
    {
        throw new NotImplementedException();
    }
}
interface Icontrols
{
    void Start();
    void Stop();
}


