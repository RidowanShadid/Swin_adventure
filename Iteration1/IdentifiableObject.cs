using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration1;
public class IdentifiableObject
{
    private List<string> _identifiers;

    public IdentifiableObject(string[] idents)
    {
        _identifiers = new List<string>(idents);
    }

    public bool AreYou(string id)
    {
        return _identifiers.Exists(identifier => string.Equals(identifier, id, StringComparison.OrdinalIgnoreCase));
    }

    public string FirstId => _identifiers.Count > 0 ? _identifiers[0] : string.Empty;

    public void AddIdentifier(string id)
    {
        string lowerId = id.ToLower();
        if (!_identifiers.Contains(lowerId))
        {
            _identifiers.Add(lowerId);
        }
    }

    // Method to expose the identifiers for demonstration purposes
    public string[] GetIdentifiers()
    {
        return _identifiers.ToArray();
    }
}
