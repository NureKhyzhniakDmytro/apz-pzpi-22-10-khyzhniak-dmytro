public class Car {
    public string Engine;
    public int Wheels;
    public bool GPS;
}

public interface ICarBuilder {
    void SetEngine(string engine);
    void SetWheels(int number);
    void SetGPS(bool hasGPS);
    Car GetResult();
}

public class SportsCarBuilder : ICarBuilder {
    private Car car = new Car();
    public void SetEngine(string engine) => car.Engine = engine;
    public void SetWheels(int number) => car.Wheels = number;
    public void SetGPS(bool hasGPS) => car.GPS = hasGPS;
    public Car GetResult() => car;
}

public class Director {
    public void BuildSportsCar(ICarBuilder builder) {
        builder.SetEngine("V8");
        builder.SetWheels(4);
        builder.SetGPS(true);
    }
}

var builder = new SportsCarBuilder();
var director = new Director();
director.BuildSportsCar(builder);
Car car = builder.GetResult();
