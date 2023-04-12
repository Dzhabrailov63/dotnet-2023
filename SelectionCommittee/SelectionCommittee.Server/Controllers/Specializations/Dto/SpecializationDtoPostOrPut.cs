﻿
namespace SelectionCommittee.Server.Controllers.Specializations.Dto;

/// <summary>
/// Dto для Post и Put операций сущности специальности.
/// </summary>
public class SpecializationDtoPostOrPut
{
    /// <summary>
    /// Идентификатор.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Приоритет.
    /// </summary>
    public int Priority { get; set; }

    /// <summary>
    /// Название.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Идентификатор факультета.
    /// </summary>
    public int FacultyId { get; set; }
}