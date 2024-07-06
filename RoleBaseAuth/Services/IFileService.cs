namespace RoleBaseAuth.Services
{
    public interface IFileService
    {
        Tuple<int, string> SaveImage(IFormFile Image);
        public bool DeleteImage(string Image);
    }
}
