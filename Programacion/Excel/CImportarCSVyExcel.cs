﻿using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultimodeSales.Programacion
{
    class CImportarCSVyExcel
    {
        public DataTable ImportarCSV(string FileName)
        {
            DataTable result = new DataTable();
            try
            {
                string delimiters = ",";
                string extension = Path.GetExtension(FileName);
                bool firstRowContainsFieldNames = true;

                if (extension.ToLower() == "txt")
                    delimiters = "\t";
                else if (extension.ToLower() == "csv")
                    delimiters = ",";

                using (TextFieldParser tfp = new TextFieldParser(FileName))
                {

                    tfp.SetDelimiters(delimiters);

                    // Get The Column Names
                    if (!tfp.EndOfData)
                    {
                        string[] fields = tfp.ReadFields();


                        for (int i = 0; i < fields.Count(); i++)
                        {
                            if (firstRowContainsFieldNames)
                                result.Columns.Add(fields[i]);
                            else
                                result.Columns.Add("Col" + i);
                        }

                        // If first line is data then add it
                        if (!firstRowContainsFieldNames)
                            result.Rows.Add(fields);
                    }

                    // Get Remaining Rows from the CSV
                    while (!tfp.EndOfData)
                        result.Rows.Add(tfp.ReadFields());
                }
                return result;
            }
            catch
            {
                MessageBox.Show("Archivo invalido o imposible de leer", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }
    }
}