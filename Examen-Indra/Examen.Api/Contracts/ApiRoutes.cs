namespace Examen.Api.Contracts
{
    public static class ApiRoutes
    {
        public const string ListPersons = "list-persons";
        public const string ListPerson = "list-person/{id:guid}";
        public const string InsertPerson = "insert-person";
        public const string UpdatePerson = "update-person";
        public const string DeletePerson = "delete-person/{id:guid}";
    }
}
