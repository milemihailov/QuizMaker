using System.Xml.Serialization;

namespace QuizMaker
{
    internal class FileReadWrite
    {
        public static string path = @"QuizData.xml";

        /// <summary>
        /// using xmlserializer to serialize list object to xml
        /// </summary>
        /// <param name="quiz"></param>
        public static void SerializeListToXmlFile(List<Question> quiz)
        {

            XmlSerializer writer = new XmlSerializer(typeof(List<Question>));
            using (FileStream file = File.Create(path))
            {
                writer.Serialize(file, quiz);
            }
        }


        /// <summary>
        /// using xmlserializer to deserialize xml to list
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        public static List<Question> SerializeXmlFileToList()
        {
            List<Question> result = new List<Question>();

            using (FileStream file = File.OpenRead(path))
            {
                XmlSerializer writer = new XmlSerializer(typeof(List<Question>));

                var list = writer.Deserialize(file) as List<Question>;

                result.AddRange(list);
            }
            return result;
        }


        /// <summary>
        /// Checks to see if xml file is missing
        /// </summary>
        /// <returns></returns>
        public static bool IsXmlFileMissing()
        {
            return File.Exists(path);
        }
    }
}
