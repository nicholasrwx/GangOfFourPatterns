// This is the way you would have to normally call an async method
var sticker = new Sticker();
await sticker.InitializeAsync();

// This ensures initialization and that the Task is awaited
var propperSticker = await PropperSticker.CreatePropperAsync();