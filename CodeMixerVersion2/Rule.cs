using ICSharpCode.NRefactory.CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeMixerVersion2
{
    public class Rule
    {
        public void ConvertNames(List<SourceFile> sourceFiles, List<NameConvert> convertedNames)
        {
            foreach (SourceFile file in sourceFiles)
            {
                #region NameSpaces
                foreach (NamespaceDeclaration name in file.NameSpaces)
                {
                    if (!convertedNames.Any(n => n.oldName == name.Name))
                    {
                        convertedNames.Add(new NameConvert() { oldName = name.Name, NewName = Mixer.Encoder(name.Name) });
                    }
                }
                #endregion

                #region Constructors
                foreach (ConstructorDeclaration constructor in file.Constructors)
                {
                    if (!convertedNames.Any(n => n.oldName == constructor.Name))
                    {
                        convertedNames.Add(new NameConvert() { oldName = constructor.Name, NewName = Mixer.Encoder(constructor.Name) });
                    }
                }
                #endregion

                #region Methods
                foreach (MethodDeclaration method in file.Methods)
                {
                    if (!convertedNames.Any(n => n.oldName == method.Name))
                    {
                        convertedNames.Add(new NameConvert() { oldName = method.Name, NewName = Mixer.Encoder(method.Name) });
                    }
                }
                #endregion

                #region Propertys
                foreach (PropertyDeclaration property in file.Propertys)
                {
                    if (!convertedNames.Any(n => n.oldName == property.Name))
                    {
                        convertedNames.Add(new NameConvert() { oldName = property.Name, NewName = Mixer.Encoder(property.Name) });
                    }
                }
                #endregion

                #region Enums
                foreach (EnumMemberDeclaration enumvalue in file.Enums)
                {
                    if (!convertedNames.Any(n => n.oldName == enumvalue.Name))
                    {
                        convertedNames.Add(new NameConvert() { oldName = enumvalue.Name, NewName = Mixer.Encoder(enumvalue.Name) });
                    }
                    //add its perent the enum name
                    string enumName = enumvalue.PrevSibling.PrevSibling.PrevSibling.PrevSibling.GetText();
                    if (!string.IsNullOrEmpty(enumName))
                    {
                        if (!string.IsNullOrWhiteSpace(enumName))
                        {
                            if (!convertedNames.Any(n => n.oldName == enumName))
                            {
                                convertedNames.Add(new NameConvert() { oldName = enumName, NewName = Mixer.Encoder(enumName) });
                            }
                        }
                    }
                }
                #endregion

                #region Fields
                foreach (FieldDeclaration field in file.Fields)
                {
                    foreach (VariableInitializer item in field.Variables)
                    {
                        if (!convertedNames.Any(n => n.oldName == item.Name))
                        {
                            convertedNames.Add(new NameConvert() { oldName = item.Name, NewName = Mixer.Encoder(item.Name) });
                        }
                    }
                }
                #endregion
            }
        }
    }
}
