using System;
using System.IO;
using System.Text;
using Newtonsoft.Json;

public static class ExtensionMethods
{
    public static T DeepCopy<T>(this T self)
    {
        var stream = new MemoryStream();

        // Boolean Specifies wether or not to leave stream open
        // when writer is closed.
        var writer = new BinaryWriter(stream, Encoding.UTF8, true);
        
        // Serialize an Object to a JSON String
        var serializedObject = JsonConvert.SerializeObject(self);

        // Convert to Binary and Write to Memory Stream
        writer.Write(serializedObject);

        // Reset the position in the current stream
        writer.Seek(0, SeekOrigin.Begin);
        
        // Close the writer ( and stream if leaveOpen flag = false )
        writer.Close();

        // Read From Stream
        var reader = new BinaryReader(stream, Encoding.UTF8, false);

        // Convert Binary back to String representation
        var result = reader.ReadString();

        // Convert JSON String back to an Object        
        return JsonConvert.DeserializeObject<T>(result);
    }

    /*
    public static T DeepCopyXml<T>(this T self)
    {
        return (T) copy;
    }
    */

}