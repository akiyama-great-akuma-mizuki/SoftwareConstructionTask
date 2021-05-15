using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Collections.Generic;
using OrderSystem;
using System.Linq;
using System;

[ApiController]
[Route("api/order")]

public class OrderController : ControllerBase
{
    private readonly TodoContext OrderDB;

    public OrderController(TodoContext context)
    {
        OrderDB = context;
        if(OrderDB.MyProducts.Count() == 0) {
            INFO.productList.ForEach(m => OrderDB.MyProducts.Add(m));
        }
        if (OrderDB.MyOrders.Count() == 0)
        {
            OrderDB.MyOrders.Add(new Order(1, new Client("test", "test")));
            OrderDB.MyOrders.Add(new Order(2, new Client("test", "test")));
            OrderDB.MyOrders.Add(new Order(3, new Client("test", "test")));
        }
        OrderDB.SaveChanges();
    }
    //查
    [HttpGet("{id}")]
    public ActionResult<Order> GetOrder(int? id)
    {
        if(id == null)
            return NotFound();
        else
        {
            var res = OrderDB.MyOrders.Include("OrderDetails").Include("User").Where(m => m.Id == id);
            if (res.FirstOrDefault() == null)
                return NotFound();
            else
                return res.FirstOrDefault();
        }
    }
    [HttpGet]
    public void clear(string str)
    {
        //if(str == "clear")
        //{
        //    OrderDB.MyClients = { };

        //}
    }
    [HttpGet]
    public ActionResult<List<Order>> GetOrder(string? user)
    {
        if (user == null)
            return NotFound();
        else
            return OrderDB.MyOrders.Include("OrderDetails")
                    .Where(m => m.Client.Name == user).ToList();
        
    }
    //增
    [HttpPost]

    public ActionResult<Order> AddOrder(Order o)
    {
        try
        {
            Console.WriteLine(o.ToString());
            OrderDB.MyOrders.Add(o);
            OrderDB.SaveChanges();
            return o;
        }
        catch(Exception e)
        {
            return BadRequest(e.InnerException.Message);
        }
    }

    //改
    //[HttpPut("{id}")]
    //public ActionResult<Order> addorderdetail(int oid, Order order)
    //{
    //    if (order.Id != oid)
    //        return BadRequest("id can not be modified!");
    //    try
    //    {
    //        OrderDB.Entry(order).State = EntityState.Modified;
    //        OrderDB.SaveChanges();

    //        return order;
    //    }
    //    catch (Exception e)
    //    {
    //        return BadRequest(e.InnerException.Message);
    //    }
    //    //console.writeline(o.tostring());

    //}
    //改
    [HttpPut("{id}")]
    public ActionResult<Order> AddOrderDetail(long id, Orderdetails detail)
    {
        Console.WriteLine(id);
        var res = OrderDB.MyOrders.Include("User").Where(m => m.Id == id).FirstOrDefault();
        if (res == null)
            return NotFound();
        else
        {
            if (res.OrderDetails.Where(d => d.OrderdetailsId == detail.OrderdetailsId).FirstOrDefault() != null)
            {
                return BadRequest("detailsId repeated!");
            }
            //终于解决了，一对多对应关系，只在数据库‘多’表中添加，不直接在‘一’表添加
            //res.OrderDetails.Add(detail);
            //OrderDB.Entry(res).State = EntityState.Modified;
            OrderDB.MyDetails.Add(detail);
            OrderDB.SaveChanges();
            return res;
        }
    }
    //删
    [HttpDelete("{id}")]
    public ActionResult<Order> DeleteOrder(long id)
    {
        try
        {
            var res = OrderDB.MyOrders.Include("OrderDetails").Include("User").Where(m => m.Id == id).FirstOrDefault();
            if(res == null)
            {
                return NotFound();
            }
            else
            {
                OrderDB.Remove(res);
                OrderDB.SaveChanges();
            }
            return res;
        }
        catch(Exception e)
        {
            return BadRequest(e.InnerException.Message);
        }
    }
  }
