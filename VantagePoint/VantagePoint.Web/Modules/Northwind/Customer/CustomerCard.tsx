namespace VantagePoint.Northwind {

    var randomImages = [
        "avatar.png",
        "avatar04.png",
        "avatar2.png",
        "avatar3.png",
        "avatar5.png"
    ];

    function getRandomImage(item: CustomerRow) {
        return Q.resolveUrl("~/Content/adminlte/img/" +
            randomImages[Math.floor(Math.random() * randomImages.length)]);
    }

    export interface CustomerCardProps {
        item: CustomerRow;
        editItem: (item: CustomerRow) => void;
    }

    export class CustomerCard extends React.Component<CustomerCardProps> {
        render(): React.ReactNode {
            var item = this.props.item;
            return (
                <table>
                    <tbody>
                        <tr>
                            <td rowSpan={4} className="img">
                                <img src={getRandomImage(item)} />
                            </td>
                        </tr>
                        <tr>
                            <td className="name">
                                <a href="javascript:;" onClick={e => this.props.editItem(item)}>
                                    {item.CustomerID} - {item.CompanyName}
                                </a>
                            </td>
                        </tr>
                        <tr>
                            <td className="contact">{item.ContactName}, {item.ContactTitle}</td>
                        </tr>
                        <tr>
                            <td className="country">{item.City}, {item.Country}</td>
                        </tr>
                    </tbody>
                </table>
            );
        }
    }
}