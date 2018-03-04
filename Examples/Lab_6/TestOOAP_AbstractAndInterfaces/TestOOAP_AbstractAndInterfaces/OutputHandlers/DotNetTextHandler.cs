using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace TestOOAP_AbstractAndInterfaces
{
    /// <summary>
    /// ������� ����� � ��������� ����.
    /// </summary>
    public class DotNetTextHandler : OutputHandler
    {
        // �����, ������� ����� � ����.
        private Stream CurrentFileStram { get; set; }
        // "��������" � �����.
        private StreamWriter OutputText { get; set; }

        /// <summary>
        /// ����������� ������ DotNetTextHandler, �������������� ����� ��������� ������� ������.
        /// </summary>
        /// <param name="FileName">��� ����� � ������� ����� ���������� ������.</param>
        public DotNetTextHandler(string FileName)
        {
            // ������������� ������ � ��������.
            CurrentFileStram = new FileStream(FileName, FileMode.Append, FileAccess.Write);
            OutputText = new StreamWriter(CurrentFileStram);
            OutputText.AutoFlush = true;
        }

        /// <summary>
        /// ���������������� �� �������� �����. �������� ������ ��� ������� ��������� ������.
        /// </summary>
        /// <param name="Text">���������� �����.</param>
        public override void Print(string Text)
        {
            // ����� � ����� ��� ������� ��������� ������.
            OutputText.Write(Text);
        }

        /// <summary>
        /// ���������������� �� �������� �����. �������� ������ � �������� ��������� ������.
        /// </summary>
        /// <param name="Text">���������� �����.</param>
        public override void PrintLine(string Text)
        {
            // ����� � ����� � �������� ��������� ������.
            OutputText.WriteLine(Text);
        }
    }
}
