using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concrete.MoodleEditor.Data;

public class CourseEntity
{
	public CourseEntity(string path)
	{
		Path = path;
	}

	public string Path { get; }
}
