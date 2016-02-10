using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace StoreOffice
{
    /// <summary>
    /// Class containing serialization functions
    /// </summary>
    public class SerializationHelper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string XMLSerializeToString(object obj)
        {
            XmlSerializer serializer = new XmlSerializer(obj.GetType());
            MemoryStream stream = new MemoryStream();
            XmlTextWriter writer = new XmlTextWriter(stream, new UTF8Encoding(false));
            //XmlTextWriter writer = new XmlTextWriter(ms, Encoding.UTF8);
            writer.Formatting = Formatting.Indented;
            writer.Indentation = 0;
            serializer.Serialize(writer, obj);
            writer.Close();
            return Encoding.UTF8.GetString(stream.ToArray());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="strXML"></param>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static object XMLDeSerializeFromString(string strXML, object obj)
        {
            return XMLDeSerializeFromString(strXML, typeof(object));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="strXML"></param>
        /// <param name="objType"></param>
        /// <returns></returns>
        public static object XMLDeSerializeFromString(string strXML, Type objType)
        {
            XmlSerializer serializer = new XmlSerializer(objType);
            MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes(strXML));
            return serializer.Deserialize(stream);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="path"></param>
        public static void XMLSerializeToFile(object obj, string path)
        {
            XmlSerializer serializer = null;
            XmlTextWriter writer = null;
            
            try
            {
                serializer = new XmlSerializer(obj.GetType());
                writer = new XmlTextWriter(path, Encoding.UTF8);
                writer.Formatting = Formatting.Indented;
                writer.Indentation = 0;
                serializer.Serialize(writer, obj);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (writer != null)
                {
                    writer.Close();
                }
                
            }            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="path"></param>
        /// <returns></returns>
        public static object XMLDeserializeFromFile(object obj, string path)
        {
            return XMLDeserializeFromFile(typeof(object), path);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="t"></param>
        /// <param name="path"></param>
        /// <returns></returns>
        public static object XMLDeserializeFromFile(Type t, string path)
        {
            XmlSerializer serializer = null;
            StreamReader reader = null;
            object obj = null;

            try
            {
                serializer = new XmlSerializer(t);
                reader = new StreamReader(path, Encoding.UTF8);
                obj = serializer.Deserialize(reader);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                    reader = null;
                }

                serializer = null;
            }  
            
            return obj;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="t"></param>
        /// <param name="path"></param>
        /// <param name="xmlns"></param>
        /// <returns></returns>
        public static object XMLDeserializeFromFile(Type t, string path, string xmlns)
        {
            XmlSerializer serializer = null;
            StreamReader reader = null;
            object obj = null;
            try
            {
                serializer = new XmlSerializer(t,xmlns);
                reader = new StreamReader(path, Encoding.UTF8);
                obj = serializer.Deserialize(reader);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                    reader = null;
                }

                serializer = null;
            }

            return obj;
        }

    }
}
