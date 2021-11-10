using Concrete.MoodleEditor.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concrete.MoodleEditor;

public interface ICourseSerializer
{
	Task<CourseEntity> ReadAsync(Stream stream, CancellationToken cancellationToken);
	Task WriteAsync(Stream stream, CourseEntity course, CancellationToken cancellationToken);
}
