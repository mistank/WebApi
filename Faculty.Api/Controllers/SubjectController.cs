using Faculty.Common.Models.Subject;
using Faculty.Core;
using Microsoft.AspNetCore.Mvc;

namespace Faculty.Controllers;

[ApiController]
[Route("api/subjects")]
public class SubjectController : Controller
{
    private readonly SubjectManager subjectManager;

    public SubjectController(SubjectManager subjectManager)
    {
        this.subjectManager = subjectManager;
    }

    [HttpPost]
    public List<SubjectModel> Create(SubjectCreateModel model)
    {
        var result = subjectManager.Create(model);
        return result;
    }
}