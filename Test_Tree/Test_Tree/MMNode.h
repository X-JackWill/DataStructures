//
//  MMNode.h
//  Test_Tree
//
//  Created by Morris_ on 2021/4/20.
//

#import <Foundation/Foundation.h>

NS_ASSUME_NONNULL_BEGIN

/// 节点
@interface MMNode : NSObject

@property (nonatomic) int data;  // 节点数据

@property (nonatomic, strong) MMNode *top;    // 父节点
@property (nonatomic, strong, nullable) MMNode *left;   // 左子节点
@property (nonatomic, strong, nullable) MMNode *right;  // 右子节点

// Node子节点数
- (NSInteger)countNodes;

// 叶子数
- (NSInteger)countLeaves;

@end


NS_ASSUME_NONNULL_END
