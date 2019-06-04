using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    Public class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook(string name) : base(name)
        {
            Type = GradeBookType.Standard;
        }
    }
}
