using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LottoBayernAnalyzer
{
    /// <summary>
    /// Class for showing different types of MessageBox'es.
    /// </summary>
    public static class MsgBox
    {
        #region Message Box Interface


        #region without owner


        /// <summary>
        /// Shows MesssageBox with error.
        /// </summary>
        /// <param name="msg">String to display.</param>
        /// <param name="list">An Object array containing zero or more objects to write using format.</param>
        public static void Error(string msg, params object[] list)
        {
            implError(null, false, msg, list);
        }

        /// <summary>
        /// Shows MesssageBox with information.
        /// </summary>
        /// <param name="msg">String to display.</param>
        /// <param name="list">An Object array containing zero or more objects to write using format.</param>
        public static void Info(string msg, params object[] list)
        {
            implInfo(null, false, msg, list);
        }

        /// <summary>
        /// Shows MesssageBox with warning.
        /// </summary>
        /// <param name="msg">String to display.</param>
        /// <param name="list">An Object array containing zero or more objects to write using format.</param>
        public static void Warning(string msg, params object[] list)
        {
            implWarning(null, false, msg, list);
        }

        /// <summary>
        /// Shows MesssageBox with cancellable warning (OK and Cancel buttons are available).
        /// </summary>
        /// <param name="msg">String to display.</param>
        /// <param name="list">An Object array containing zero or more objects to write using format.</param>
        public static DialogResult WarningCancel(string msg, params object[] list)
        {
            return implWarningCancel(null, false, msg, list);
        }

        /// <summary>
        /// Shows MesssageBox with question.
        /// </summary>
        /// <param name="msg">String to display.</param>
        /// <param name="list">An Object array containing zero or more objects to write using format.</param>
        public static DialogResult Question(string msg, params object[] list)
        {
            return implQuestion(null, false, msg, list);
        }

        /// <summary>
        /// Shows MesssageBox with cancellable question.
        /// </summary>
        /// <param name="msg">String to display.</param>
        /// <param name="list">An Object array containing zero or more objects to write using format.</param>
        public static DialogResult QuestionCancel(string msg, params object[] list)
        {
            return implQuestionCancel(null, false, msg, list);
        }

        /// <summary>
        /// Shows MesssageBox with exception.
        /// </summary>
        /// <param name="ex">Exception to display.</param>
        /// <param name="msg">Additional string to display.</param>
        /// <param name="list">An Object array containing zero or more objects to write using format.</param>
        public static void Exception(Exception ex, string msg, params object[] list)
        {
            implException(null, false, ex, false, msg, list);
        }

        /// <summary>
        /// Shows MesssageBox with exception (and full exception info).
        /// </summary>
        /// <param name="ex">Exception to display.</param>
        /// <param name="msg">Additional string to display.</param>
        /// <param name="list">An Object array containing zero or more objects to write using format.</param>
        public static void ExceptionFull(Exception ex, string msg, params object[] list)
        {
            implException(null, false, ex, true, msg, list);
        }


        #endregion


        #region with owner


        /// <summary>
        /// Shows MesssageBox with error.
        /// </summary>
        /// <param name="owner">
        /// Any object that implements System.Windows.Forms.IWin32Window that represents
        /// the top-level window that will own the modal dialog box.
        /// </param>
        /// <param name="msg">String to display.</param>
        /// <param name="list">An Object array containing zero or more objects to write using format.</param>
        public static void Error(IWin32Window owner, string msg, params object[] list)
        {
            implError(owner, false, msg, list);
        }

        /// <summary>
        /// Shows MesssageBox with information.
        /// </summary>
        /// <param name="owner">
        /// Any object that implements System.Windows.Forms.IWin32Window that represents
        /// the top-level window that will own the modal dialog box.
        /// </param>
        /// <param name="msg">String to display.</param>
        /// <param name="list">An Object array containing zero or more objects to write using format.</param>
        public static void Info(IWin32Window owner, string msg, params object[] list)
        {
            implInfo(owner, false, msg, list);
        }

        /// <summary>
        /// Shows MesssageBox with warning.
        /// </summary>
        /// <param name="owner">
        /// Any object that implements System.Windows.Forms.IWin32Window that represents
        /// the top-level window that will own the modal dialog box.
        /// </param>
        /// <param name="msg">String to display.</param>
        /// <param name="list">An Object array containing zero or more objects to write using format.</param>
        public static void Warning(IWin32Window owner, string msg, params object[] list)
        {
            implWarning(owner, false, msg, list);
        }

        /// <summary>
        /// Shows MesssageBox with cancellable warning (OK and Cancel buttons are available).
        /// </summary>
        /// <param name="owner">
        /// Any object that implements System.Windows.Forms.IWin32Window that represents
        /// the top-level window that will own the modal dialog box.
        /// </param>
        /// <param name="msg">String to display.</param>
        /// <param name="list">An Object array containing zero or more objects to write using format.</param>
        public static DialogResult WarningCancel(IWin32Window owner, string msg, params object[] list)
        {
            return implWarningCancel(owner, false, msg, list);
        }

        /// <summary>
        /// Shows MesssageBox with question.
        /// </summary>
        /// <param name="owner">
        /// Any object that implements System.Windows.Forms.IWin32Window that represents
        /// the top-level window that will own the modal dialog box.
        /// </param>
        /// <param name="msg">String to display.</param>
        /// <param name="list">An Object array containing zero or more objects to write using format.</param>
        public static DialogResult Question(IWin32Window owner, string msg, params object[] list)
        {
            return implQuestion(owner, false, msg, list);
        }

        /// <summary>
        /// Shows MesssageBox with cancellable question.
        /// </summary>
        /// <param name="owner">
        /// Any object that implements System.Windows.Forms.IWin32Window that represents
        /// the top-level window that will own the modal dialog box.
        /// </param>
        /// <param name="msg">String to display.</param>
        /// <param name="list">An Object array containing zero or more objects to write using format.</param>
        public static DialogResult QuestionCancel(IWin32Window owner, string msg, params object[] list)
        {
            return implQuestionCancel(owner, false, msg, list);
        }

        /// <summary>
        /// Shows MesssageBox with exception.
        /// </summary>
        /// <param name="owner">
        /// Any object that implements System.Windows.Forms.IWin32Window that represents
        /// the top-level window that will own the modal dialog box.
        /// </param>
        /// <param name="ex">Exception to display.</param>
        /// <param name="msg">Additional string to display.</param>
        /// <param name="list">An Object array containing zero or more objects to write using format.</param>
        public static void Exception(IWin32Window owner, Exception ex, string msg, params object[] list)
        {
            implException(owner, false, ex, false, msg, list);
        }

        /// <summary>
        /// Shows MesssageBox with exception (and full exception info).
        /// </summary>
        /// <param name="owner">
        /// Any object that implements System.Windows.Forms.IWin32Window that represents
        /// the top-level window that will own the modal dialog box.
        /// </param>
        /// <param name="ex">Exception to display.</param>
        /// <param name="msg">Additional string to display.</param>
        /// <param name="list">An Object array containing zero or more objects to write using format.</param>
        public static void ExceptionFull(IWin32Window owner, Exception ex, string msg, params object[] list)
        {
            implException(owner, false, ex, true, msg, list);
        }


        #endregion


        #endregion


        #region Text Box Interface


        //#region without owner


        ///// <summary>
        ///// Shows MesssageBox with error.
        ///// </summary>
        ///// <param name="msg">String to display.</param>
        ///// <param name="list">An Object array containing zero or more objects to write using format.</param>
        //public static void TextError(string msg, params object[] list)
        //{
        //    implError(null, true, msg, list);
        //}

        ///// <summary>
        ///// Shows text MesssageBox with information.
        ///// </summary>
        ///// <param name="msg">String to display.</param>
        ///// <param name="list">An Object array containing zero or more objects to write using format.</param>
        //public static void TextInfo(string msg, params object[] list)
        //{
        //    implInfo(null, true, msg, list);
        //}

        ///// <summary>
        ///// Shows text MesssageBox with warning.
        ///// </summary>
        ///// <param name="msg">String to display.</param>
        ///// <param name="list">An Object array containing zero or more objects to write using format.</param>
        //public static void TextWarning(string msg, params object[] list)
        //{
        //    implWarning(null, true, msg, list);
        //}

        ///// <summary>
        ///// Shows text MesssageBox with cancellable warning (OK and Cancel buttons are available).
        ///// </summary>
        ///// <param name="msg">String to display.</param>
        ///// <param name="list">An Object array containing zero or more objects to write using format.</param>
        //public static DialogResult TextWarningCancel(string msg, params object[] list)
        //{
        //    return implWarningCancel(null, true, msg, list);
        //}

        ///// <summary>
        ///// Shows text MesssageBox with question.
        ///// </summary>
        ///// <param name="msg">String to display.</param>
        ///// <param name="list">An Object array containing zero or more objects to write using format.</param>
        //public static DialogResult TextQuestion(string msg, params object[] list)
        //{
        //    return implQuestion(null, true, msg, list);
        //}

        ///// <summary>
        ///// Shows text MesssageBox with cancellable question.
        ///// </summary>
        ///// <param name="msg">String to display.</param>
        ///// <param name="list">An Object array containing zero or more objects to write using format.</param>
        //public static DialogResult TextQuestionCancel(string msg, params object[] list)
        //{
        //    return implQuestionCancel(null, true, msg, list);
        //}

        ///// <summary>
        ///// Shows text MesssageBox with exception.
        ///// </summary>
        ///// <param name="ex">Exception to display.</param>
        ///// <param name="msg">Additional string to display.</param>
        ///// <param name="list">An Object array containing zero or more objects to write using format.</param>
        //public static void TextException(Exception ex, string msg, params object[] list)
        //{
        //    implException(null, true, ex, false, msg, list);
        //}

        ///// <summary>
        ///// Shows text MesssageBox with exception (and full exception info).
        ///// </summary>
        ///// <param name="ex">Exception to display.</param>
        ///// <param name="msg">Additional string to display.</param>
        ///// <param name="list">An Object array containing zero or more objects to write using format.</param>
        //public static void TextExceptionFull(Exception ex, string msg, params object[] list)
        //{
        //    implException(null, true, ex, true, msg, list);
        //}


        //#endregion


        //#region without owner


        ///// <summary>
        ///// Shows MesssageBox with error.
        ///// </summary>
        ///// <param name="owner">
        ///// Any object that implements System.Windows.Forms.IWin32Window that represents
        ///// the top-level window that will own the modal dialog box.
        ///// </param>
        ///// <param name="msg">String to display.</param>
        ///// <param name="list">An Object array containing zero or more objects to write using format.</param>
        //public static void TextError(IWin32Window owner, string msg, params object[] list)
        //{
        //    implError(owner, true, msg, list);
        //}

        ///// <summary>
        ///// Shows text MesssageBox with information.
        ///// </summary>
        ///// <param name="owner">
        ///// Any object that implements System.Windows.Forms.IWin32Window that represents
        ///// the top-level window that will own the modal dialog box.
        ///// </param>
        ///// <param name="msg">String to display.</param>
        ///// <param name="list">An Object array containing zero or more objects to write using format.</param>
        //public static void TextInfo(IWin32Window owner, string msg, params object[] list)
        //{
        //    implInfo(owner, true, msg, list);
        //}

        ///// <summary>
        ///// Shows text MesssageBox with warning.
        ///// </summary>
        ///// <param name="owner">
        ///// Any object that implements System.Windows.Forms.IWin32Window that represents
        ///// the top-level window that will own the modal dialog box.
        ///// </param>
        ///// <param name="msg">String to display.</param>
        ///// <param name="list">An Object array containing zero or more objects to write using format.</param>
        //public static void TextWarning(IWin32Window owner, string msg, params object[] list)
        //{
        //    implWarning(owner, true, msg, list);
        //}

        ///// <summary>
        ///// Shows text MesssageBox with cancellable warning (OK and Cancel buttons are available).
        ///// </summary>
        ///// <param name="owner">
        ///// Any object that implements System.Windows.Forms.IWin32Window that represents
        ///// the top-level window that will own the modal dialog box.
        ///// </param>
        ///// <param name="msg">String to display.</param>
        ///// <param name="list">An Object array containing zero or more objects to write using format.</param>
        //public static DialogResult TextWarningCancel(IWin32Window owner, string msg, params object[] list)
        //{
        //    return implWarningCancel(owner, true, msg, list);
        //}

        ///// <summary>
        ///// Shows text MesssageBox with question.
        ///// </summary>
        ///// <param name="owner">
        ///// Any object that implements System.Windows.Forms.IWin32Window that represents
        ///// the top-level window that will own the modal dialog box.
        ///// </param>
        ///// <param name="msg">String to display.</param>
        ///// <param name="list">An Object array containing zero or more objects to write using format.</param>
        //public static DialogResult TextQuestion(IWin32Window owner, string msg, params object[] list)
        //{
        //    return implQuestion(owner, true, msg, list);
        //}

        ///// <summary>
        ///// Shows text MesssageBox with cancellable question.
        ///// </summary>
        ///// <param name="owner">
        ///// Any object that implements System.Windows.Forms.IWin32Window that represents
        ///// the top-level window that will own the modal dialog box.
        ///// </param>
        ///// <param name="msg">String to display.</param>
        ///// <param name="list">An Object array containing zero or more objects to write using format.</param>
        //public static DialogResult TextQuestionCancel(IWin32Window owner, string msg, params object[] list)
        //{
        //    return implQuestionCancel(owner, true, msg, list);
        //}

        ///// <summary>
        ///// Shows text MesssageBox with exception.
        ///// </summary>
        ///// <param name="owner">
        ///// Any object that implements System.Windows.Forms.IWin32Window that represents
        ///// the top-level window that will own the modal dialog box.
        ///// </param>
        ///// <param name="ex">Exception to display.</param>
        ///// <param name="msg">Additional string to display.</param>
        ///// <param name="list">An Object array containing zero or more objects to write using format.</param>
        //public static void TextException(IWin32Window owner, Exception ex, string msg, params object[] list)
        //{
        //    implException(owner, true, ex, false, msg, list);
        //}

        ///// <summary>
        ///// Shows text MesssageBox with exception (and full exception info).
        ///// </summary>
        ///// <param name="owner">
        ///// Any object that implements System.Windows.Forms.IWin32Window that represents
        ///// the top-level window that will own the modal dialog box.
        ///// </param>
        ///// <param name="ex">Exception to display.</param>
        ///// <param name="msg">Additional string to display.</param>
        ///// <param name="list">An Object array containing zero or more objects to write using format.</param>
        //public static void TextExceptionFull(IWin32Window owner, Exception ex, string msg, params object[] list)
        //{
        //    implException(owner, true, ex, true, msg, list);
        //}


        //#endregion


        #endregion


        #region Implementation


        private static void implError(IWin32Window owner, bool bText, string msg, params object[] list)
        {
            messageBox(owner, bText, msg, MessageBoxButtons.OK, MessageBoxIcon.Error, "- Error", list);
        }

        private static void implInfo(IWin32Window owner, bool bText, string msg, params object[] list)
        {
            messageBox(owner, bText, msg, MessageBoxButtons.OK, MessageBoxIcon.Information, "- Information", list);
        }

        private static void implWarning(IWin32Window owner, bool bText, string msg, params object[] list)
        {
            messageBox(owner, bText, msg, MessageBoxButtons.OK, MessageBoxIcon.Warning, "- Warning", list);
        }

        private static DialogResult implWarningCancel(IWin32Window owner, bool bText, string msg, params object[] list)
        {
            return messageBox(owner, bText, msg, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, "- Warning", list);
        }

        private static DialogResult implQuestion(IWin32Window owner, bool bText, string msg, params object[] list)
        {
            return messageBox(owner, bText, msg, MessageBoxButtons.YesNo, MessageBoxIcon.Question, "- Question", list);
        }

        private static DialogResult implQuestionCancel(IWin32Window owner, bool bText, string msg, params object[] list)
        {
            return messageBox(owner, bText, msg, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, "- Question", list);
        }

        private static void implException(IWin32Window owner, bool bText, Exception ex, bool bFull, string msg, params object[] list)
        {
            implError(owner, bText, (String.IsNullOrEmpty(msg) ? String.Empty : (msg + Environment.NewLine + Environment.NewLine)) +
               (bFull ? ex.ToString() : ex.Message), list);
        }


        /// <summary>
        /// Converts verbatim string litreral (@"") to regular.
        /// </summary>
        private static string verbatimToRegular(string msg)
        {
            msg = msg.Replace(@"\n", "\n");
            msg = msg.Replace(@"\r", "\r");
            msg = msg.Replace(@"\t", "\t");
            return msg;
        }


        /// <summary>
        /// Gets the current assembly product name attribute.
        /// </summary>
        private static string ProductName
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                // If there aren't any Product attributes, return an empty string
                if (attributes.Length == 0)
                    return String.Empty;
                // If there is a Product attribute, return its value
                else
                    return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }


        /// <summary>
        /// Internal function to display various message boxes.
        /// </summary>
        private static DialogResult messageBox(IWin32Window owner, bool bText, string msg, MessageBoxButtons buttons,
            MessageBoxIcon icon, string caption, params object[] list)
        {
            // show text box
            //TODO: text message box requires a form (is not currently implemented)
            if (bText)
            {
                //FrmTextMsgBox textBox = new FrmTextMsgBox(String.Format(msg, list),
                //   Properties.Resources.sProductName + " " + caption, buttons, icon);
                //if (owner != null)
                //{
                //    return InvokeMsgBox(owner, (ShowMsgBoxDelegate)delegate
                //    {
                //        return textBox.ShowDialog(owner);
                //    });
                //}
                //else
                //    return textBox.ShowDialog();
                return DialogResult.Cancel;
            }
            // show message box
            else
            {
                if (owner != null)
                {
                    return InvokeMsgBox(owner, (ShowMsgBoxDelegate)delegate
                    {
                        return MessageBox.Show(owner, String.Format(msg, list),
                            ProductName + " " + caption, buttons, icon);
                    });
                }
                else
                    return MessageBox.Show(String.Format(msg, list),
                        ProductName + " " + caption, buttons, icon);
            }
        }


        #endregion


        #region invoke implementation


        private delegate DialogResult ShowMsgBoxDelegate();


        private static DialogResult InvokeMsgBox(IWin32Window owner, ShowMsgBoxDelegate funcShow)
        {
            if ((owner != null) && (owner is Form) && (owner as Form).InvokeRequired)
                return (DialogResult)(owner as Form).Invoke(funcShow);
            else
                return funcShow();
        }


        #endregion
    }
}
