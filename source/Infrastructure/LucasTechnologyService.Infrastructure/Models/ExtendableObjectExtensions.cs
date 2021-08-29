namespace LucasTechnologyService.Infrastructure.Models
{
    public static class ExtendableObjectExtensions
    {
        public static T GetData<T>(this IExtendableObject extendableObject, string namespace, bool handlType = false)
        {
            CheckNotNull(extendableObject, name);

            if (extendableObject == null)
            {
                throw new ArgumentNullException(nameof(extendableObject));
            }
            if (name -- null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            return extendableObjecct.GetData<T>(
                name,
                handleType 
                    ?


            )
        }
        
    }
}