define(['knockout', 'customBindings'],
    function (ko) {

        function AddToWallet(params) {
            this.showModal = ko.observable(false);
            this.selectedCurrency = ko.observable(null);
            this.amount = ko.observable(null);
            this.currencyList = params.Currencies;
            this.baseCurrency = params.BaseCurrency;
            this.wallet = params.Wallet;

            this.setupSubscribes();
        }

        AddToWallet.prototype.setupSubscribes = function () {
            var self = this;

            this.showModal.subscribe(function (value) {
                if (!value) {
                    self.amount(null);
                    self.selectedCurrency(self.currencyList()[0]);
                }
            });
        };

        AddToWallet.prototype.addToWallet = function () {
            this.wallet.push({ amount: this.amount(), currency: this.selectedCurrency() });
            this.showModal(false);
        };

        AddToWallet.prototype.toggleModal = function () {
            this.showModal(!this.showModal());
        };

        ko.components.unregister('add-to-wallet');
        ko.components.register('add-to-wallet', {
            viewModel: AddToWallet,
            template: { require: 'text!Content/Wallet/add-to-wallet.html' }
        });
    }
);