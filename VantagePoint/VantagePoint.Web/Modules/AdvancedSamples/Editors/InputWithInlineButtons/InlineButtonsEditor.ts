
namespace VantagePoint.AdvancedSamples {

    /**
     * This is an editor widget with inline buttons
     */
    @Serenity.Decorators.registerEditor()
    export class InlineButtonsEditor extends Serenity.StringEditor {

        constructor(container: JQuery) {
            super(container);

            $('<a class="inplace-button inplace-action1"><b><i class="fa fa-bell-o"></i></b></a>')
                .attr("title", "Do Some Action 1")
                .insertAfter(this.element)
                .click(e => {
                    Q.notifySuccess("Action 1 with bell clicked!");
                });

            $('<a class="inplace-button inplace-action1"><b><i class="fa fa-floppy-o text-orange"></i></b></a>')
                .attr("title", "Do Some Action 1")
                .insertAfter(this.element)
                .click(e => {
                    Q.notifyInfo("Action 2 with disk clicked!");
                });
        }
    }
}