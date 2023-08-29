using System.Xml.Serialization;

public class GeradorDeXml
{
    public string GeraXml(object o)
    {
        XmlSerializer serializer = new XmlSerializer(o.GetType());
        StringWriter writer = new StringWriter();
        serializer.Serialize(writer, o);

        return writer.ToString();
    }
}