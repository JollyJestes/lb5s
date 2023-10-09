public class Tram : BaseInform
{
    public int NumberOfWagons { get; set; }
    public bool LowFloor { get; set; }
    public string Route { get; set; }

    public override string ToString()
    {
        return $"{base.ToString()}, Количество вагонов: {NumberOfWagons}, Низкопольный: {(LowFloor ? "Да" : "Нет")}, Маршрут: {Route}";
    }
}