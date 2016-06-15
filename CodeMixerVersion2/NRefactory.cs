using ICSharpCode.NRefactory.CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeMixerVersion2
{
    public class NRefactory
    {
        //####################################################################
        //
        //
        // NRefactory Code Finders
        //
        //####################################################################
        public  SyntaxTree ParseCode(string sourceCode)
        {
            CSharpParser parser = new CSharpParser();
            SyntaxTree syntaxTree = parser.Parse(sourceCode);
            return syntaxTree;
        }

        public  IEnumerable<NamespaceDeclaration> FindNameSpaces(SyntaxTree syntaxTree)
        {
            IEnumerable<NamespaceDeclaration> resuilt = syntaxTree.Descendants.OfType<NamespaceDeclaration>();
            if (resuilt != null)
            {
                return resuilt;
            }
            return null;
        }
        public  IEnumerable<ConstructorDeclaration> FindConstructor(SyntaxTree syntaxTree)
        {
            IEnumerable<ConstructorDeclaration> resuilt = syntaxTree.Descendants.OfType<ConstructorDeclaration>();
            if (resuilt != null)
            {
                return resuilt;
            }
            return null;
        }
        public  IEnumerable<MethodDeclaration> FindMethods(SyntaxTree syntaxTree)
        {
            IEnumerable<MethodDeclaration> resuilt = syntaxTree.Descendants.OfType<MethodDeclaration>();
            if (resuilt != null)
            {
                return resuilt;
            }
            return null;
        }
        public  IEnumerable<PropertyDeclaration> FindProopertys(SyntaxTree syntaxTree)
        {
            IEnumerable<PropertyDeclaration> resuilt = syntaxTree.Descendants.OfType<PropertyDeclaration>();
            if (resuilt != null)
            {
                return resuilt;
            }
            return null;
        }
        public  IEnumerable<EnumMemberDeclaration> FindEnums(SyntaxTree syntaxTree)
        {
            IEnumerable<EnumMemberDeclaration> resuilt = syntaxTree.Descendants.OfType<EnumMemberDeclaration>();
            if (resuilt != null)
            {
                return resuilt;
            }
            return null;
        }
        public  IEnumerable<VariableDeclarationStatement> FindVariables(SyntaxTree syntaxTree)
        {
            IEnumerable<VariableDeclarationStatement> resuilt = syntaxTree.Descendants.OfType<VariableDeclarationStatement>();
            if (resuilt != null)
            {
                return resuilt;
            }
            return null;
        }
        public  IEnumerable<FieldDeclaration> FindFields(SyntaxTree syntaxTree)
        {
            IEnumerable<FieldDeclaration> resuilt = syntaxTree.Descendants.OfType<FieldDeclaration>();
            if (resuilt != null)
            {
                return resuilt;
            }
            return null;
        }
    }
}
