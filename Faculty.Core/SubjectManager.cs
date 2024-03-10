using System.Diagnostics.SymbolStore;
using Faculty.Common.Models.Subject;
using Faculty.Entities;

namespace Faculty.Core;

public class SubjectManager
{
    public List<SubjectModel> subjects = new List<SubjectModel>();

    public SubjectManager()
    {
    }
// asdfasd
    public List<SubjectModel> Create(SubjectCreateModel model)
    {
        var newSubject = new SubjectModel()
        {
            Name = model.Name
        };
        subjects.Add(newSubject);
        return subjects;
    }
}