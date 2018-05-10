define([
    'jquery',
    'bootstrap',
    'knockout'],
    function ($, bootstrap, ko) {
        ko.bindingHandlers.bootstrapShowModal = {
            init: function (element, valueAccessor, allBindingsAccessor) {
                var $element = $(element);
                var allBindings = allBindingsAccessor();
                var onhide = allBindings.onhide || null;

                $element.on('hide.bs.modal', function () {
                    var value = valueAccessor();
                    if ($.isFunction(onhide) && ko.utils.unwrapObservable(value)) {
                        onhide();
                    }
                });
            },
            update: function (element, valueAccessor) {
                var value = valueAccessor();
                if (ko.utils.unwrapObservable(value)) {
                    $(element).modal('show');
                    // this is to focus input field inside dialog
                    $("input", element).focus();
                }
                else {
                    $(element).modal('hide');
                }
            }
        };
    }
);