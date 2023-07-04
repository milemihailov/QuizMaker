﻿using System.Xml.Serialization;

namespace QuizMaker
{
    internal class ListToXmlFile
    {
        public static string path = @"D:\serialize\QuizData.xml";

        public static void SerializeListToXmlFile(List<Question> quiz)
        {
            XmlSerializer writer = new XmlSerializer(typeof(List<Question>));
            using (FileStream file = File.Create(path))
            {
                writer.Serialize(file, quiz);
            }
        }
        public static void SerializeXmlFileToList(List<Question> result)
        {
            using (FileStream file = File.OpenRead(path))
            {
                XmlSerializer writer = new XmlSerializer(typeof(List<Question>));

                var list = writer.Deserialize(file) as List<Question>;

                result.AddRange(list);
            }
        }
    }
}