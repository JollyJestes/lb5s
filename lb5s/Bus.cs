public class Bus : BaseInform
{
    public int SeatingCapacity { get; set; }
    public int StandingCapacity { get; set; }
    public bool AirConditioning { get; set; }

    public override string ToString()
    {
        return $"{base.ToString()}, Количество сидячих мест: {SeatingCapacity}, Количество стоячих мест: {StandingCapacity}, Кондиционер: {(AirConditioning ? "Да" : "Нет")}";
    }
}