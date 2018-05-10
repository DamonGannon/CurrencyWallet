define(['knockout'],
    function (ko) {

        function WalletSummary(params) {
            this.loading = ko.observable(false);
            this.wallet = params.Wallet;
            this.currencies = params.Currencies
            this.selectedCurrency = ko.observable(null);

            this.setupSubscribes();
        }

        WalletSummary.prototype.setupSubscribes = function () {
            var self = this;

            this.wallet.subscribe(function (change) {
                var update = change[0];
                if (update.status === 'added') {
                    update.value.amount = (update.value.amount * 1).toFixed(2);
                    update.value.convertedAmount = ko.computed(function () {
                        return ((update.value.amount / update.value.currency.Rate()) * self.selectedCurrency().Rate()).toFixed(2);
                    });
                }
            }, null, "arrayChange");
        }

        ko.components.unregister('wallet-summary');
        ko.components.register('wallet-summary', {
            viewModel: WalletSummary,
            template: { require: 'text!Content/Wallet/wallet-summary.html' }
        });
    }
);