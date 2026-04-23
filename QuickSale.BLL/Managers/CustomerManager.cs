using QuickSale.DAL.Interfaces;
using QuickSale.DAL.Models;

namespace QuickSale.BLL.Managers;

public class CustomerManager
{
    private readonly IRepository<Customer> _customerRepo;

    public CustomerManager(IRepository<Customer> customerRepo)
    {
        _customerRepo = customerRepo;
    }

    public void AddCustomer(string name, string phone, string email)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Customer name cannot be empty.", nameof(name));

        _customerRepo.Add(new Customer
        {
            Name = name.Trim(),
            Phone = phone.Trim(),
            Email = email.Trim()
        });
        _customerRepo.Save();
    }

    public void UpdateCustomer(int id, string name, string phone, string email)
    {
        var customer = _customerRepo.GetById(id)
            ?? throw new KeyNotFoundException($"Customer with ID {id} not found.");

        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Customer name cannot be empty.", nameof(name));

        customer.Name = name.Trim();
        customer.Phone = phone.Trim();
        customer.Email = email.Trim();

        _customerRepo.Update(customer);
        _customerRepo.Save();
    }

    public List<Customer> GetAllCustomers()
        => _customerRepo.GetAll().ToList();

    public void DeleteCustomer(int id)
    {
        _ = _customerRepo.GetById(id)
            ?? throw new KeyNotFoundException($"Customer with ID {id} not found.");

        _customerRepo.Delete(id);
        _customerRepo.Save();
    }

    public List<Customer> SearchCustomers(string keyword)
    {
        if (string.IsNullOrWhiteSpace(keyword))
            return GetAllCustomers();

        var kw = keyword.Trim().ToLower();

        return _customerRepo.GetAll()
            .Where(c => c.Name.ToLower().Contains(kw)
                     || c.Phone.ToLower().Contains(kw)
                     || c.Email.ToLower().Contains(kw))
            .ToList();
    }
}
