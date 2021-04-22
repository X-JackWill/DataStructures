//
//  main.m
//  Test_Tree
//
//  Created by Morris_ on 2021/4/20.
//

#import <Foundation/Foundation.h>
#import "MMTree.h"
#import "MMNode.h"


int main(int argc, const char * argv[]) {
    @autoreleasepool {
        
        // 创建一个二叉树对象
        MMTree *tree = [[MMTree alloc] init];
        
        // 创建二叉树的跟节点
        MMNode *rootNode = [[MMNode alloc] init];
        rootNode.data = 0;
        tree.rootNode = rootNode;
        
        /**
                  0
        */
        
        // 添加一些字节点
        MMNode *node10 = [[MMNode alloc] init];
        MMNode *node11 = [[MMNode alloc] init];
        node10.data = 10;
        node11.data = 11;
        [tree addLeftNode:node10 inNode:rootNode];
        [tree addRightNode:node11 inNode:rootNode];

        /**
                  0
              10     11
        */

        MMNode *node20 = [[MMNode alloc] init];
        MMNode *node21 = [[MMNode alloc] init];
        node20.data = 20;
        node21.data = 21;
        [tree addLeftNode:node20 inNode:node10];
        [tree addRightNode:node21 inNode:node10];
        
        /**
                  0
              10     11
           20   21
        */


        MMNode *node32 = [[MMNode alloc] init];
        MMNode *node33 = [[MMNode alloc] init];
        node32.data = 32;
        node33.data = 33;
        [tree addLeftNode:node32 inNode:node21];
        [tree addRightNode:node33 inNode:node21];
        
        /**
                  0
              10     11
           20   21
             32   33
        */

        MMNode *node30 = [[MMNode alloc] init];
        node30.data = 30;
        [tree addLeftNode:node30 inNode:node20];

        /**
                    0
               10      11
            20      21
         30      32    33
        */
        
        MMNode *node44 = [[MMNode alloc] init];
        node44.data = 44;
        node44.top = node33; // 默认添加在父节点的左节点上

        /**
                    0
               10      11
            20      21
         30      32    33
                            44
        */

        NSLog(@"%ld",(long)[tree countNodes]);
        NSLog(@"%ld",(long)[tree countLeaves]);
    }
    return 0;
}
