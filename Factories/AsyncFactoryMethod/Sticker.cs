public class Sticker
{

    public Sticker()
    {

    }

    public async Task<Sticker> InitializeAsync()
    {
        await Taskk.Delay(2000);
        return this;
    }
}