// All types in this file will be defined in this file-scoped namespace.
namespace Packt.Shared;

public class Person : object
{

  #region Fields: Data or state for this person. (Public fields to store person data)

  public string? Name; // The sign means it field probably can be null.
  public DateTimeOffset Born; // DateTimeOffset is a struct, so it can't be null and store the date in UTC (Universal Time Coordinated).

  #endregion


  #region Store favorite ancient world wonder.
  public WondersOfTheAncientWorld wondersOfTheAncientWorld;

  #endregion


}
