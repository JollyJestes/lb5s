public class BaseInform
{
    public string TransportType { get; set; }
    public int Capacity { get; set; }
    public int YearOfManufacture { get; set; }
    public string Manufacturer { get; set; }
    public double Price { get; set; }

    public override string ToString()
    {
        return $"Тип транспорта: {TransportType}, Вместимость: {Capacity}, Год выпуска: {YearOfManufacture}, Производитель: {Manufacturer}, Цена: {Price}";
    }
}
