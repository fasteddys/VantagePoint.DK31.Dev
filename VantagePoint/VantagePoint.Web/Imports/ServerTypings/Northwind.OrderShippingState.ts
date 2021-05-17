namespace VantagePoint.Northwind {
    export enum OrderShippingState {
        NotShipped = 0,
        Shipped = 1
    }
    Serenity.Decorators.registerEnumType(OrderShippingState, 'VantagePoint.Northwind.OrderShippingState', 'Northwind.OrderShippingState');
}
