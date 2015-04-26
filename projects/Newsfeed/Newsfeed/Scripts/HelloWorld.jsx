var HelloWorld = React.createClass({
    render: function() {
        return (
			<div className="card">
				<h2>Hello {this.props.name}!</h2>
				<div>This component is alive for {this.state.time} seconds.</div>
			</div>
		);
	},
	getInitialState: function() {
      return { time: 0 };
    },
	 
	componentDidMount: function() {
		this._timeout = setInterval(function () {
            this.setState({time: this.state.time + 1});
         }.bind(this), 1000);

	},
	componentWillUnmount: function(){
		// Clear the timeout
		clearInterval(this._timeout); 
    }
});
