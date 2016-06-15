using ICSharpCode.NRefactory.CSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeMixerVersion2
{
    class Program
    {
        private static Rule _rule;
        private static NRefactory _refactory;

        static void Main(string[] args)
        {
            _rule = new Rule();
            _refactory = new NRefactory();

            List<SourceFile> sourceFiles = new List<SourceFile>();
            List<NameConvert> convertedNames = new List<NameConvert>();

            //find all .cs files in the dir
            foreach (string file in FindFiles("C:\\Test"))
            {
                string sourceCode = ReadSourceFile(file);
                SyntaxTree syntaxTree = _refactory.ParseCode(sourceCode);

                //build our object
                SourceFile sourceFile = BuildSourceFile(file, syntaxTree, _refactory);

                //add to list of files we can fuck up with
                sourceFiles.Add(sourceFile);
            }

            // check if there are some files to change
            if (sourceFiles.Count > 0)
            {
                //convert all names to some random text
                _rule.ConvertNames(sourceFiles, convertedNames);

                //time to update our source files with the new names
                foreach (SourceFile file in sourceFiles)
                {
                    //read in the original file
                    string oldCode = null;
                    using (StreamReader reader = new StreamReader(file.FileName))
                    {
                        oldCode = reader.ReadToEnd();
                    }

                    //loop throw converted names and replace in file
                    foreach (NameConvert name in convertedNames)
                    {
                        oldCode = oldCode.Replace(name.oldName, name.NewName);
                    }

                    // Do some checking here to see if still vailed
                    if (_refactory.ParseCode(oldCode) != null)
                    {
                        //wite changes back to file
                        using (StreamWriter writer = new StreamWriter(file.FileName))
                        {
                            writer.Write(oldCode);
                            writer.Flush();
                        }
                    }
                }
            }
        }

        private static SourceFile BuildSourceFile(string file, SyntaxTree syntaxTree, NRefactory refactory)
        {
            SourceFile sourceFile = new SourceFile(file);
            sourceFile.NameSpaces = refactory.FindNameSpaces(syntaxTree).ToList();
            sourceFile.Constructors = refactory.FindConstructor(syntaxTree).ToList();
            sourceFile.Methods = refactory.FindMethods(syntaxTree).ToList();
            sourceFile.Propertys = refactory.FindProopertys(syntaxTree).ToList();
            sourceFile.Enums = refactory.FindEnums(syntaxTree).ToList();
            sourceFile.Variables = refactory.FindVariables(syntaxTree).ToList();
            sourceFile.Fields = refactory.FindFields(syntaxTree).ToList();
            return sourceFile;
        }

        private static IEnumerable<string> FindFiles(string location)
        {
            return Directory.GetFiles(location, "*.cs", SearchOption.AllDirectories);
        }

        private static string ReadSourceFile(string file)
        {
            using (StreamReader reader = new StreamReader(file))
            {
                return reader.ReadToEnd();
            }
            return null;
        }
    }
}
