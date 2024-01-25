public class PropperSticker
{
    private PropperSticker() { };

    private async Task<PropperSticker> InitializePropperAsync()
    {
        await Task.Delay(1000);
        return this;
    };

    // this ensures that the object is initialized
    // we only have to await the create method to create an instance, and run the task
    public static Task<PropperSticker> CreatePropperAsync() {
        var result = new PropperSticker();
        return result.InitializePropperAsync();
    };
}