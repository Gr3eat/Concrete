using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concrete.MoodleEditor.Data;

public class QuizEntity
{
	public List<CategoryEntity> Categories { get; set; } = new();
}
