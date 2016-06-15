using ICSharpCode.NRefactory.CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeMixerVersion2
{
    public class SourceFile
    {
        private List<NamespaceDeclaration> _namesSpaces;
        private List<ConstructorDeclaration> _constructors;
        private List<MethodDeclaration> _methods;
        private List<PropertyDeclaration> _propertys;
        private List<EnumMemberDeclaration> _enums;
        private List<VariableDeclarationStatement> _variables;
        private List<FieldDeclaration> _fields;
        public SourceFile()
        {
            Init();
        }
        public SourceFile(string fileName)
        {
            FileName = fileName;
            Init();
        }
        private void Init()
        {
            _namesSpaces = new List<NamespaceDeclaration>();
            _constructors = new List<ConstructorDeclaration>();
            _methods = new List<MethodDeclaration>();
            _propertys = new List<PropertyDeclaration>();
            _enums = new List<EnumMemberDeclaration>();
            _variables = new List<VariableDeclarationStatement>();
            _fields = new List<FieldDeclaration>();
        }
        public string FileName { get; set; }
        public List<NamespaceDeclaration> NameSpaces
        {
            get { return _namesSpaces; }
            set { _namesSpaces = value; }
        }
        public List<ConstructorDeclaration> Constructors
        {
            get { return _constructors; }
            set { _constructors = value; }
        }
        public List<MethodDeclaration> Methods
        {
            get { return _methods; }
            set { _methods = value; }
        }
        public List<PropertyDeclaration> Propertys
        {
            get { return _propertys; }
            set { _propertys = value; }
        }
        public List<EnumMemberDeclaration> Enums
        {
            get { return _enums; }
            set { _enums = value; }
        }
        public List<VariableDeclarationStatement> Variables
        {
            get { return _variables; }
            set { _variables = value; }
        }
        public List<FieldDeclaration> Fields
        {
            get { return _fields; }
            set { _fields = value; }
        }
    }
}
