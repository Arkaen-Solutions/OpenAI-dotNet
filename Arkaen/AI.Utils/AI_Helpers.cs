using System.Net;
using System.Security;
using System.Security.Cryptography;

namespace AI.Utils;

[Flags]
public enum AuthLevel {
	Default		= 0x00,
	None		= -1,
	Server		= 0x01,
	Secondary	= 0x02,
	Critical	= 2 << 1,
} ;

public interface IWebEndpoint {
	Uri Uri { get; set; }
	string Name { get; set; }
	string Description { get; set; }
	NetworkCredential Credentials { get; set; }
} ;

