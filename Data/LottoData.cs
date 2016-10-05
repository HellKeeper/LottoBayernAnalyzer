using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression;
using System.Net;
using System.IO;

using LINQtoCSV;


namespace LottoBayernAnalyzer.Data
{
    public class Lotto6from49
    {
        public class DataEntry
        {
            #region Data fields


            [CsvColumn(Name = "Tag")]
            public int Day { get; set; }

            [CsvColumn(Name = "Monat")]
            public int Month { get; set; }

            [CsvColumn(Name = "Jahr")]
            public int Year { get; set; }


            [CsvColumn(Name = "Zahl1")]
            public int Num1 { get; set; }

            [CsvColumn(Name = "Zahl2")]
            public int Num2 { get; set; }

            [CsvColumn(Name = "Zahl3")]
            public int Num3 { get; set; }

            [CsvColumn(Name = "Zahl4")]
            public int Num4 { get; set; }

            [CsvColumn(Name = "Zahl5")]
            public int Num5 { get; set; }

            [CsvColumn(Name = "Zahl6")]
            public int Num6 { get; set; }


            [CsvColumn(Name = "Super")]
            public int SuperNum { get; set; }


            #endregion


            public DateTime Date { get { return new DateTime(this.Year, this.Month, this.Day); } }
        }


        /// <summary>
        /// Gets the data from the LOTTO archive.
        /// </summary>
        /// <param name="url">URL to get archive file from.</param>
        /// <param name="filename">Name of the CSV file with data inside the archive.</param>
        /// <returns>Returns initialized list of the data from archive on success; throws exception otherwise.</returns>
        public static List<DataEntry> GetArchiveData(string url, string filename)
        {
            var data = new List<DataEntry>();

            try
            {
                // download archive from the url
                var wc = new WebClient();
                using (var archStream = new MemoryStream(wc.DownloadData(url)))
                {
                    // open the downloadede ZIP archive
                    using (var archive = new ZipArchive(archStream))
                    {
                        // get the file needed
                        var entry = archive.GetEntry(filename);
                        if (entry == null)
                            throw new Exception(String.Format("Cannot find '{0}' in the archive!", filename));

                        using (var entStream = entry.Open())
                        {
                            using (var tmpStream = new MemoryStream())
                            {
                                // buffer the original stream to the temp stream to make it seekable (this is required for CsvContext.Read)
                                entStream.CopyTo(tmpStream);
                                tmpStream.Position = 0;

                                using (var entReader = new StreamReader(tmpStream))
                                {
                                    // prepare the CSV file description (to correctly ignore the unknown and not specified columns)
                                    var csvFileDescr = new CsvFileDescription
                                    {
                                        SeparatorChar = '\x09',
                                        FirstLineHasColumnNames = true,
                                        EnforceCsvColumnAttribute = false,
                                        IgnoreUnknownColumns = true,
                                    };

                                    // read the contents using LINQtoCSV
                                    var rawData = new CsvContext().Read<DataEntry>(entReader, csvFileDescr);

                                    data = rawData.ToList();
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("Cannot get the archive data for 'Lotto 6 from 49' from URL ('{1}'):\n\n{0}",
                    ex.Message, url), ex);
            }

            return data;
        }
    }
}
