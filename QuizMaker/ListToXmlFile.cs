using System.Xml.Serialization;

namespace QuizMaker
{
    internal class ListToXmlFile
    {
        public static void SerializeListToXmlFile(List<Question> quiz)
        {
            XmlSerializer writer = new XmlSerializer(typeof(List<Question>));

            string path = @"D:\serialize\QuizData.xml";

            using (FileStream file = File.Create(path))
            {
                writer.Serialize(file, quiz);
            }
        }
    }
}
