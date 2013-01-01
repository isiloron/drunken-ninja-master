//Denna klass är ett verktyg hämtat från csharpskolan.se

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;
using System.IO.IsolatedStorage;

namespace Grupp_7_Projekt
{
	//Denna klass är ett verktyg hämtat från csharpskolan.se
	public static class XMLSerialiserare<T> where T : class
	{
		public static T Load(string path)
		{
			T serializableObject = LoadFromDocumentFormat(null, path, null);
			return serializableObject;
		}

		public static void Save(T serializableObject, string path)
		{
			SaveToDocumentFormat(serializableObject, null, path, null);
		}


	
		private static T LoadFromDocumentFormat(System.Type[] extraTypes, string path,
			IsolatedStorageFile isolatedStorageFolder)
		{
			T serializableObject = null;

			using (TextReader textReader = CreateTextReader(isolatedStorageFolder, path))
			{
				XmlSerializer xmlSerializer = CreateXmlSerializer(extraTypes);
				serializableObject = xmlSerializer.Deserialize(textReader) as T;
			}
			return serializableObject;
		}

		private static TextReader CreateTextReader(IsolatedStorageFile isolatedStorageFolder, string path)
		{
			TextReader textReader = null;

			if (isolatedStorageFolder == null)
				textReader = new StreamReader(path);
			else
				textReader = new StreamReader(new IsolatedStorageFileStream(path,
					FileMode.Open, isolatedStorageFolder));

			return textReader;
		}

		private static void SaveToDocumentFormat(T serializableObject,
			System.Type[] extraTypes, string path, IsolatedStorageFile isolatedStorageFolder)
		{
			using (TextWriter textWriter = CreateTextWriter(isolatedStorageFolder, path))
			{
				XmlSerializer xmlSerializer = CreateXmlSerializer(extraTypes);
				xmlSerializer.Serialize(textWriter, serializableObject);
			}
		}

		private static TextWriter CreateTextWriter(IsolatedStorageFile
							isolatedStorageFolder, string path)
		{
			TextWriter textWriter = null;

			if (isolatedStorageFolder == null)
				textWriter = new StreamWriter(path);
			else
				textWriter = new StreamWriter(new IsolatedStorageFileStream(path,
								  FileMode.OpenOrCreate, isolatedStorageFolder));

			return textWriter;
		}

		private static XmlSerializer CreateXmlSerializer(System.Type[] extraTypes)
		{
			Type ObjectType = typeof(T);

			XmlSerializer xmlSerializer = null;

			if (extraTypes != null)
				xmlSerializer = new XmlSerializer(ObjectType, extraTypes);
			else
				xmlSerializer = new XmlSerializer(ObjectType);

			return xmlSerializer;
		}

	}
	
	//Följande två klasser är egenskrivna.
	public static class SparaOchLaddaXML
	{
		public static void Ladda(out List<Recept> receptlista)
		{
			ReceptBok bok = XMLSerialiserare<ReceptBok>.Load("receptbok.xml");
			receptlista = bok.receptlista;
		}

		public static void Spara(ref List<Recept> receptlista)
		{
			ReceptBok bok = new ReceptBok();
			bok.receptlista = receptlista;
			XMLSerialiserare<ReceptBok>.Save(bok, "receptbok.xml");
		}
	}

	public class ReceptBok
	{
		public string ägare = "Grupp 7";
		public List<Recept> receptlista = new List<Recept>();
	}
}
