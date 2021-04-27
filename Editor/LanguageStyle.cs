using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Editor
{
    public class LanguageStyle
    {
        /*
         * C C++ PYTHON JAVA SQL PHP 高亮样式
         */
        public void styleSolution(RichTextBox editText, string Keyword, string func)
        {
            // 字符串判断
            bool notStr = true;
            int wordPos = 0, i = 0;
            foreach (char ch in editText.Text)
            {
                // 字符串颜色
                if (ch == '"' || ch == '\'') 
                {
                    notStr = !notStr; 
                    editText.Select(i, 1); 
                    editText.SelectionColor = Color.Chocolate;
                }
                
                if (notStr)
                {
                    int ich = ch;
                    if ((ich < 65 || ich > 90) && (ich < 97 || ich > 122))
                    {
                        string str = editText.Text.Substring(wordPos, i - wordPos);
                        // editText.Select(wordPos + 1, i - wordPos - 1);
                        editText.Select(wordPos, i - wordPos);
                        // 函数方法颜色
                        if (ch == '(')
                        {
                            // editText.Select(wordPos + 1, i - wordPos - 1);
                            editText.SelectionColor = Color.FromArgb(102, 8, 116);
                        }
                        // 关键词颜色
                        if (Regex.IsMatch(str, Keyword))
                        {
                            editText.SelectionColor = Color.FromArgb(74, 144, 226);
                        }
                        // 常用函数颜色
                        if (Regex.IsMatch(str, func))
                        {
                            editText.SelectionColor = Color.FromArgb(204, 232, 207);
                        }
                        wordPos = i;
                    }
                    // 数值颜色
                    if (ich >= 48 && ich <= 57)
                    {
                        editText.Select(i, 1);
                        editText.SelectionColor = Color.FromArgb(255, 217, 0);
                    }    
                }
                else
                {
                    editText.Select(i, 1); 
                    editText.SelectionColor = Color.Chocolate;
                }
                i++;
            }
            // 推进光标
            editText.Select(i, 0);
        }
        public void language(string type, RichTextBox editText)
        {
            editText.ForeColor = Color.FromArgb(237, 235, 233);
            if (Regex.IsMatch(type, "c|(cpp)"))
            {
                styleSolution(editText,
                    "(false)|(true)|(null)|(break)|(class)|(continue)|(private)|(protected)|(this)" +
                    "|(friend)|(else)|(catch)|(public)|(for)|(int)|(include)|(if)|(double)|(float)|(default)" +
                    "|(string)|(char)|(new)|(static)|(extern)|(const)|(return)|(try)|(while)|(delete)|(template)" +
                    "|(void)|(bool)|(switch)|(case)|(long)|(short)|(do)",
                    "(cin)|(cout)|(printf)|(sprintf)");
            }
            else if (Regex.IsMatch(type, "py"))
            {
                styleSolution(editText, 
                    "(False)|(True)|(None)|(and)|(as)|(assert)|(break)|(class)|(continue)|(def)" +
                    "|(del)|(elif)|(else)|(except)|(finally)|(for)|(from)|(global)|(if)|(import)|(in)|(global)" +
                    "|(is)|(lambda)|(nonlocal)|(not)|(or)|(pass)|(raise)|(return)|(try)|(while)|(with)|(yield)|(self)",
                    "(print)|(input)|(raw_input)|(format)|(max)|(min)|(set)|(range)|(abs)|(pow)|(round)|(count)");
            }
            else if (Regex.IsMatch(type, "java"))
            {
                styleSolution(editText,
                    "(false)|(true)|(null)|(break)|(class)|(continue)|(private)|(protected)|(this)|(final)" +
                    "|(else)|(catch)|(public)|(for)|(int)|(include)|(if)|(double)|(float)|(abstract)|(default)|(implements)" +
                    "|(String)|(char)|(new)|(static)|(import)|(const)|(return)|(try)|(while)|(delete)|(template)" +
                    "|(void)|(boolean)|(long)|(short)|(byte)|(interface)|(throw)|(finally)|(switch)|(case)|(do)|(enum)" +
                    "|(instanceof)|(super)|(synchronized)|(transient)|(extends)",
                    "");
            }
            else if (Regex.IsMatch(type, "sql"))
            {
                styleSolution(editText,
                    "(databases)|(table)|(column)|(int)|(float)|(char)|(varchar)|(smallint)|(bigint)|(datetime)|(decimal)|(binary)|(image)|(bit)|(text)|(money)" +
                    "|(DATABASES)|(TABLE)|(COLUMN)|(INT)|(FLOAT)|(CHAR)|(VARCHAR)|(SMALLINT)|(BIGINT)|(DATETIME)|(DECIMAL)|(BINARY)|(IMAGE)|(BIT)|(TEXT)|(MONEY)",
                    "(select)|(use)|(from)|(alter)|(delete)|(drop)|(create)|(update)|(where)|(as)|(primary)|(foreign)|(key)|(except)|(union)|(intersect)" +
                    "|(SELECT)|(USE)|(FROM)|(ALTER)|(DELETE)|(DROP)|(CREATE)|(UPDATE)|(WHERE)|(AS)|(PRIMARY)|(FOREIGN)|(KEY)|(EXCEPT)|(UNION)|(INTERSECT)" +
                    "|(set)|(join)|(left)|(right)|(insert)|(into)|(values)|(add)|(and)|(or)|(not)|(all)|(distinct)|(null)|(between)|(desc)|(asc)|(order)|(by)|(is)" +
                    "|(SET)|(JOIN)|(LEFT)|(RIGHT)|(INSERT)|(INTO)|(VALUES)|(ADD)|(AND)|(OR)|(NOT)|(ALL)|(DISTINCT)|(NULL)|(BETWEEN)|(DESC)(ASC)|(ORDER)|(BY)|(IS)" +
                    "|(avg)|(min)|(max)|(sum)|(count)|(group)|(having)" +
                    "|(AVG)|(MIN)|(MAX)|(SUM)|(COUNT)|(GROUP)|(HAVING)"
                );
            }
            else if (Regex.IsMatch(type, "php"))
            {
                styleSolution(editText, 
                    "(final)|(const)|(static)|(public)|(function)|(private)|(new)|(array)|(if)|(else)|(switch)|(case)|(while)|(for)|(do)|(return)|(true)|(false)", 
                    "(echo)|(var_dump)|(header)|(include)|(inculde_once)|(isset)|(round)|(explode)|(opendir)|(scandir)|(closedir)|(readdir)|(sprintf)|(count)"
                );
            }
        }
    }
}