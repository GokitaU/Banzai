// import { combineReducers } from 'redux'
import { CHANGE_STATUS, GameStatus } from '../actions'

export function banzaiApp(state = {status: GameStatus.NOT_STARTED}, action) {
  switch (action.type) {
    case CHANGE_STATUS:
      return [
        Object.assign({}, {
          status: action.status
        })
      ]
    default:
      return state
  }
}
// const banzaiApp = combineReducers({
//   statuses,
//   visibilityFilter
// })

// export default banzaiApp
