public class Trolleybus : BaseInform
{
    public int Voltage { get; set; }
    public string PowerSupply { get; set; }
    public string RouteNumber { get; set; }

    public override string ToString()
    {
        return $"{base.ToString()}, Напряжение: {Voltage}, Источник питания: {PowerSupply}, Номер маршрута: {RouteNumber}";
    }
}