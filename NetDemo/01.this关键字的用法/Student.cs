//这是 Student.cs 类

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.this关键字的用法
{
    internal class Student
    {

        public Student() { }

        public List<StuScores> stuScores = new List<StuScores>();

        /// <summary>
        /// 单参数索引器：获取学生成绩对象
        /// </summary>
        /// <param name="stuName"></param>
        /// <returns></returns>
        public List<StuScores> this[string stuName]
        {
            get
            {
                return stuScores.Where(t => t.StuName == stuName).ToList();
            }
        }

        /// <summary>
        /// 多参数索引器：获取学生成绩对象
        /// </summary>
        /// <returns></returns>
        public int this[string stuName, int courseID]
        {
            get
            {
                if (stuScores.Any(t => t.StuName == stuName && t.CourseID == courseID))
                {
                    return stuScores.First(t => t.StuName == stuName && t.CourseID == courseID).CourseScore;
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                stuScores.Add(new StuScores { StuName = stuName, CourseID = courseID, CourseScore = value });
            }
        }
    }

    /// <summary>
    /// 学生成绩对象
    /// </summary>

    internal class StuScores
    {
        public StuScores() { }

        /// <summary>
        /// 名称
        /// </summary>
        public string StuName { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public int CourseID { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        public int CourseScore { get; set; }
    }
}
